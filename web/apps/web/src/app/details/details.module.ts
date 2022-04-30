import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { FlexLayoutModule } from '@angular/flex-layout';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { MatIconModule } from '@angular/material/icon';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatTooltipModule } from '@angular/material/tooltip';
import { RouterModule, Routes } from '@angular/router';

import { DetailsComponent } from './details.component';
import { LicenseDetailsComponent } from './license-details/license-details.component';
import { LinksComponent } from './links/links.component';
import { MaintainerDetailsComponent } from './maintainer-details/maintainer-details.component';

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
    LinksComponent,
    MaintainerDetailsComponent,
  ],
  imports: [
    CommonModule,
    FlexLayoutModule,
    MatButtonModule,
    MatCardModule,
    MatIconModule,
    MatSidenavModule,
    MatTooltipModule,
    RouterModule.forChild(routes),
  ],
})
export class DetailsModule {}
