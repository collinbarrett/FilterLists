import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { MatChipsModule } from '@angular/material/chips';
import { MatIconModule } from '@angular/material/icon';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatSortModule } from '@angular/material/sort';
import { MatTableModule } from '@angular/material/table';
import { MatTooltipModule } from '@angular/material/tooltip';
import { RouterModule,Routes } from '@angular/router';

import { DirectoryComponent } from './directory.component';

const routes: Routes = [
  {
    path: '',
    component: DirectoryComponent,
    loadChildren: () =>
      import('../details/details.module').then((d) => d.DetailsModule),
  },
];

@NgModule({
  declarations: [DirectoryComponent],
  imports: [
    CommonModule,
    MatButtonModule,
    MatChipsModule,
    MatIconModule,
    MatPaginatorModule,
    MatSortModule,
    MatTableModule,
    MatTooltipModule,
    RouterModule.forChild(routes),
  ],
})
export class DirectoryModule {}
