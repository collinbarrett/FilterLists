import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { DetailsComponent } from './details.component';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MaintainerDetailsComponent } from './maintainer-details/maintainer-details.component';
import { MatCardModule } from '@angular/material/card';
import { MatIconModule } from '@angular/material/icon';
import { MatTooltipModule } from '@angular/material/tooltip';
import { LicenseDetailsComponent } from './license-details/license-details.component';

const routes: Routes = [
  {
    path: 'lists/:listId',
    component: DetailsComponent,
  },
];

@NgModule({
  declarations: [
    DetailsComponent,
    LicenseDetailsComponent,
    MaintainerDetailsComponent,
  ],
  imports: [
    CommonModule,
    MatCardModule,
    MatIconModule,
    MatSidenavModule,
    MatTooltipModule,
    RouterModule.forChild(routes),
  ],
})
export class DetailsModule {}
