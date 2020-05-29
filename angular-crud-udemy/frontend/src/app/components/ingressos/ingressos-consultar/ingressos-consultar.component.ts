import { Component, OnInit } from '@angular/core';
import {Ingresso} from "../ingresso.model";
import {IngressosService} from "../ingressos.service";

@Component({
  selector: 'app-ingressos-consultar',
  templateUrl: './ingressos-consultar.component.html',
  styleUrls: ['./ingressos-consultar.component.css']
})
export class IngressosConsultarComponent implements OnInit {

  ingressos: Ingresso[]
  displayedColumns = ['id', 'name', 'price', 'action']

  constructor(private ingressoService: IngressosService) { }

  ngOnInit(): void {
    this.ingressoService.read().subscribe(ingressos => {
      this.ingressos = ingressos
      console.log(ingressos)
    })
  }

}
