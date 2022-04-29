import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { DetailsComponent } from './details.component';
import { MatSidenavModule } from '@angular/material/sidenav';

const routes: Routes = [
  {
    path: 'lists/:listId',
    component: DetailsComponent,
  },
];

@NgModule({
  declarations: [DetailsComponent],
  imports: [CommonModule, MatSidenavModule, RouterModule.forChild(routes)],
})
export class DetailsModule {}
