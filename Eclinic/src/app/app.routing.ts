/**
 * Created by Sunkee on 24-Jan-18.
 */
import {RouterModule,Route} from '@angular/router';
import {LoginComponent} from "./login/login.component";
import {HomeComponent} from "./home/home.component";

const routes: Route[] = [
  {path:'index',component:HomeComponent},
  {path:'login',component:LoginComponent},
  {path:'', component:LoginComponent},
  {path:'**', component:LoginComponent}
]

export const AppRoutes = RouterModule.forRoot(routes);
