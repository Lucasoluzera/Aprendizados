import {Component} from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'GED Angular v1';
  selectedFile = null;

  constructor(private http: HttpClient) {
  }

  onFileSelected(event) {
    if (event.target.files && event.target.files[0]) {
      const pdf = event.target.files[0];

      const formData = new FormData();
      formData.append('pdf', pdf);

      this.http.post('http://localhost:8080/pdf', formData)
        .subscribe(resposta => console.log('Upload Ok.'));
    }
  }
}
