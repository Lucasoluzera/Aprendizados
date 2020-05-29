import {NgModule} from '@angular/core';
import {Routes, RouterModule} from '@angular/router';

import {HomeComponent} from "./views/home/home.component";

import {IngressosCrudComponent} from "./views/ingressos-crud/ingressos-crud.component";
import {IngressosCadastroComponent} from "./components/ingressos/ingressos-cadastro/ingressos-cadastro.component";
import {IngressosAlterarComponent} from "./components/ingressos/ingressos-alterar/ingressos-alterar.component";


const routes: Routes = [
    {
        path: "",
        component: HomeComponent
    },
    {
        path: "ingressos",
        component: IngressosCrudComponent
    },
    {
        path: "ingressos/cadastro",
        component: IngressosCadastroComponent
    },
    {
        path: "ingressos/alterar/:id",
        component: IngressosAlterarComponent
    }
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule {
}
