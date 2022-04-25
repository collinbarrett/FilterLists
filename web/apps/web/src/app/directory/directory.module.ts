import { NgModule } from '@angular/core';
import { MatTableModule } from '@angular/material/table';
import { MatPaginatorModule } from '@angular/material/paginator';
import { MatSortModule } from '@angular/material/sort';
import { MatChipsModule } from '@angular/material/chips';
import { DirectoryComponent } from './directory.component';
import { CommonModule } from '@angular/common';
import { DirectoryRoutingModule } from './directory-routing.module';

@NgModule({
  declarations: [DirectoryComponent],
  imports: [
    CommonModule,
    DirectoryRoutingModule,
    MatChipsModule,
    MatPaginatorModule,
    MatSortModule,
    MatTableModule,
  ],
})
export class DirectoryModule {}
