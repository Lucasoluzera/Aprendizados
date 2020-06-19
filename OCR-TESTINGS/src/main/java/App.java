import net.sourceforge.tess4j.Tesseract;
import net.sourceforge.tess4j.TesseractException;
import net.sourceforge.tess4j.util.PdfUtilities;
import org.apache.pdfbox.pdmodel.PDDocument;
import org.apache.pdfbox.rendering.PDFRenderer;
import org.apache.pdfbox.text.PDFTextStripper;

import javax.imageio.ImageIO;
import java.awt.*;
import java.awt.image.BufferedImage;
import java.io.File;
import java.io.IOException;
import java.util.Date;
public class App {

    public static void main(String[] args) throws IOException, TesseractException {

        /* PT-BR
            O resultado depende mais do PDF usado.
            Não existe um resultado muito gritante somente segundos pequenas 1 ou 2.
            Porém o PDFBOX só é útil quando o pdf é nativo para imagens ele não consegue ler.
         */

        /* ENG-US
            The result depends more on the PDF used.
            There is not a very striking result, only small 1 or 2 seconds.
            However PDFBOX is only useful when the pdf is native to images it cannot read.
        */

        Tesseract _tesseract = new Tesseract();
        _tesseract.setLanguage("eng");
        //TODO CONFIGURE A PASTA DO TESSDATA, ESSA É A PADRÃO DO MEU PC / CONFIGURE TESSDATA PATH
        _tesseract.setDatapath("C:\\cursos-testes-tudo\\OCR-TESTINGS\\tessdata\\");
        //TODO CONFIGURE A PASTA DO PDF PARA TESTE, ESSA É A PADRÃO DO MEU PC // CONFIGURE DOCUMENT PATH
        String url = "C:\\cursos-testes-tudo\\OCR-TESTINGS\\pdfs-teste\\sample.pdf";
        ocrPDDocument(url, _tesseract);

        pdfBox(url);
        ocrPDDocument(url, _tesseract);
        ocrPdfUtilities(url, _tesseract);
        ocrNativo(url, _tesseract);
    }

    public static void pdfBox(String url) throws IOException, TesseractException {
        System.err.println("Inicio: " + new Date());
        File arquivo = new File(url);

        PDDocument pdDocument = PDDocument.load(arquivo);

        PDFTextStripper pdfTextStripper = new PDFTextStripper();

        String ocrResult = pdfTextStripper.getText(pdDocument);


        System.err.println(ocrResult);
        System.err.println("Fim: " + new Date());
    }

    public static void ocrPDDocument(String url, Tesseract _tesseract) throws IOException, TesseractException {
        System.err.println("Inicio: " + new Date());

        String ocrResult = "";

        BufferedImage bufferedImage = binarizarImagem(new File(url));
        ocrResult += _tesseract.doOCR(bufferedImage);


        System.err.println(ocrResult);


        System.err.println("Fim: " + new Date());

    }

    public static void ocrPdfUtilities(String url, Tesseract _tesseract) throws IOException, TesseractException {
        //5segundos 35MB
        //3segundos para converter para image
        System.err.println("Inicio: " + new Date());

        String ocrResult = "";

        File arquivo = new File(url);
        File pngImageFiles[] = PdfUtilities.convertPdf2Png(arquivo);
        for (int i = 0; i < pngImageFiles.length; i++) {
            ocrResult = _tesseract.doOCR(pngImageFiles[i]);
        }
        System.err.println(ocrResult);
        System.err.println("Fim: " + new Date());
    }

    public static void ocrNativo(String url, Tesseract _tesseract) throws TesseractException {
        System.err.println("Inicio: " + new Date());


        File arquivo = new File(url);
        String result = _tesseract.doOCR(arquivo);

        System.err.println(result);

        System.err.println("Fim: " + new Date());
    }

    public static BufferedImage binarizarImagem(File arquivo) throws IOException {

        BufferedImage image = null;

        PDDocument document = PDDocument.load(arquivo);

        PDFRenderer pdfRenderer = new PDFRenderer(document);

        try {
            image = pdfRenderer.renderImageWithDPI(0, 600);
        } catch (IOException e) {
            e.printStackTrace();
        }

        int h = image.getHeight();
        int w = image.getWidth();

        BufferedImage bufferedImage = new BufferedImage(w, h, BufferedImage.TYPE_INT_RGB);

        for (int i = 0; i < w; i++) {
            for (int j = 0; j < h; j++) {
                int val = image.getRGB(i, j);
                int r = (0x00ff0000 & val) >> 16;
                int g = (0x0000ff00 & val) >> 8;
                int b = (0x000000ff & val);
                int m = (r + g + b);
                if (m >= 383) {
                    bufferedImage.setRGB(i, j, Color.WHITE.getRGB());
                } else {
                    bufferedImage.setRGB(i, j, 0);
                }
            }
        }
        File arquivoParaSalvar = new File("C:\\cursos-testes-tudo\\OCR-TESTINGS\\pdfs-teste\\binarizado.png");
        ImageIO.write(bufferedImage, "png", arquivoParaSalvar);
        return bufferedImage;
    }
}
