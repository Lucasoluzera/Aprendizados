import { Injectable } from '@angular/core';
import {MatSnackBar} from "@angular/material/snack-bar";
import {HttpClient} from "@angular/common/http";
import {Ingresso} from "./ingresso.model";
import {Observable} from "rxjs";

@Injectable({
  providedIn: 'root'
})
export class IngressosService {


  baseUrl = "http://localhost:3001/products"

  constructor(private snackBar: MatSnackBar, private http: HttpClient) { }

  showMessage(msg: string): void{
    this.snackBar.open(msg, 'x',{
      duration: 3000,
      horizontalPosition: "right",
      verticalPosition: "top"
    })
  }

    create(ingresso: Ingresso): Observable<Ingresso>{
      return this.http.post<Ingresso>(this.baseUrl, ingresso)
    }

  read(): Observable<Ingresso[]>{
    return this.http.get<Ingresso[]>(this.baseUrl)
  }

  readById(id: string): Observable<Ingresso> {
    const url = `${this.baseUrl}/${id}`
    return this.http.get<Ingresso>(url)
  }

  update(ingresso: Ingresso): Observable<Ingresso>{
    const url = `${this.baseUrl}/${ingresso.id}`
    return this.http.put<Ingresso>(url, ingresso)
  }

  delete(id: string): Observable<Ingresso>{
    const url = `${this.baseUrl}/${id}`
    return  this.http.delete<Ingresso>(url)
  }
}
