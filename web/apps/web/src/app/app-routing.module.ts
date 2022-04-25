import { NgModule } from '@angular/core';
import { DirectoryComponent } from './directory/directory.component';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [{ path: '', component: DirectoryComponent }];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
