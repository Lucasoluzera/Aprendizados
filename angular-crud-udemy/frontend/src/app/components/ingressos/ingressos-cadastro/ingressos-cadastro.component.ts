import { Component, OnInit } from '@angular/core';
import {IngressosService} from "../ingressos.service";
import {Router} from "@angular/router";
import {Ingresso} from "../ingresso.model";

@Component({
  selector: 'app-ingressos-cadastro',
  templateUrl: './ingressos-cadastro.component.html',
  styleUrls: ['./ingressos-cadastro.component.css']
})
export class IngressosCadastroComponent implements OnInit {

  ingresso: Ingresso ={
    name: '',
    price: null
  }

  constructor(
      private ingressosService: IngressosService,
      private router: Router
  ) { }

  ngOnInit(): void {
  }

  cadastrarIngresso(): void{
    this.ingressosService.create(this.ingresso).subscribe( () =>{
      this.ingressosService.showMessage('Rolê cadastrado com sucesso!')
      this.router.navigate(['/ingressos'])
    })

  }

  cancelar(): void{
    this.router.navigate(['/ingressos'])
  }
}
