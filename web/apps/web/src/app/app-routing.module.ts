import { NgModule } from '@angular/core';
import { DirectoryTableComponent } from './directory-table/directory-table.component';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [{ path: '', component: DirectoryTableComponent }];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
