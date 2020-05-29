import { AfterViewInit, Component, OnInit, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTable } from '@angular/material/table';
import { IngressosConsultar2DataSource } from './ingressos-consultar2-datasource';
import {Ingresso} from "../ingresso.model";

@Component({
  selector: 'app-ingressos-consultar2',
  templateUrl: './ingressos-consultar2.component.html',
  styleUrls: ['./ingressos-consultar2.component.css']
})
export class IngressosConsultar2Component implements AfterViewInit, OnInit {
  @ViewChild(MatPaginator) paginator: MatPaginator;
  @ViewChild(MatSort) sort: MatSort;
  @ViewChild(MatTable) table: MatTable<Ingresso>;
  dataSource: IngressosConsultar2DataSource;

  /** Columns displayed in the table. Columns IDs can be added, removed, or reordered. */
  displayedColumns = ['id', 'name', 'price'];

  ngOnInit() {
    this.dataSource = new IngressosConsultar2DataSource();
  }

  ngAfterViewInit() {
    this.dataSource.sort = this.sort;
    this.dataSource.paginator = this.paginator;
    this.table.dataSource = this.dataSource;
  }
}
