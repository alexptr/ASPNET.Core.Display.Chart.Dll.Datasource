import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ChartAreaComponent } from './chartArea/chartArea.component';

const routes: Routes = [
  { path: '', redirectTo: '/home', pathMatch: 'full' },
  { path: 'home', component: ChartAreaComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
