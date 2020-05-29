import {Component, OnInit} from '@angular/core';
import {IngressosService} from "../ingressos.service";
import {ActivatedRoute, Router} from "@angular/router";
import {Ingresso} from "../ingresso.model";

@Component({
    selector: 'app-ingressos-alterar',
    templateUrl: './ingressos-alterar.component.html',
    styleUrls: ['./ingressos-alterar.component.css']
})
export class IngressosAlterarComponent implements OnInit {

    ingresso: Ingresso

    constructor(private ingressosService: IngressosService,
                private router: Router,
                private route: ActivatedRoute
    ) {
    }

    ngOnInit(): void {
        const id = this.route.snapshot.paramMap.get('id')
        this.ingressosService.readById(id).subscribe(ingresso => {
            this.ingresso = ingresso
        });
    }

    alterarIngresso(): void {
        this.ingressosService.update(this.ingresso).subscribe(() => {
            this.ingressosService.showMessage('Ingresso atualizado com sucesso')
            this.router.navigate(['/ingressos'])
        })
    }

    cancelar(): void {
        this.router.navigate(['/ingressos'])
    }

    excluir(): void{
        this.ingressosService.delete(this.ingresso.id.toString()).subscribe( () =>
        {
            this.ingressosService.showMessage('Excluido com sucesso')
            this.router.navigate(['/ingressos'])
        })
    }


}
