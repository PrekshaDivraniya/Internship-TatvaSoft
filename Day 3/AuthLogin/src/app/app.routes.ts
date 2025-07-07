import { Routes } from '@angular/router';

export const routes: Routes = [
    {
        path:'',
        pathMatch:'full',
        loadComponent:()=>{
            return import('./registration/registration.component')
            .then((m)=>m.RegistrationComponent);
        }
    },
    {
        path:'login',
        loadComponent: ()=>{
            return import('./login/login.component')
            .then((m)=>m.LoginComponent);
        }
    }
];
