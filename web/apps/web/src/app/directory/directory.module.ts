import { NgModule } from '@angular/core';
import { MatTableModule } from '@angular/material/table';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatSortModule } from '@angular/material/sort';
import { MatChipsModule } from '@angular/material/chips';
import { DirectoryComponent } from './directory.component';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    component: DirectoryComponent,
  },
];

@NgModule({
  declarations: [DirectoryComponent],
  imports: [
    CommonModule,
    MatChipsModule,
    MatPaginatorModule,
    MatSortModule,
    MatTableModule,
    RouterModule.forChild(routes),
  ],
})
export class DirectoryModule {}
