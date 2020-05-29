import { Component, OnInit } from '@angular/core';
import {Router} from "@angular/router";

@Component({
  selector: 'app-ingressos-crud',
  templateUrl: './ingressos-crud.component.html',
  styleUrls: ['./ingressos-crud.component.css']
})
export class IngressosCrudComponent implements OnInit {

  constructor(private router: Router) { }

  ngOnInit(): void {
  }

  navigateToProductCreate() : void{
    this.router.navigate(['/ingressos/cadastro'])
    console.log('create')
  }

}
