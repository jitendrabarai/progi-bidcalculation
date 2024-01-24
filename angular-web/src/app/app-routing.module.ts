//used to define and configure the routing structure for the application.
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FormdetailsComponent } from './pages/formdetails/formdetails.component';

const routes: Routes = [
  {path:'',redirectTo:'bidCalculate',pathMatch:'full'},
  {path: 'bidCalculate',component:FormdetailsComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
