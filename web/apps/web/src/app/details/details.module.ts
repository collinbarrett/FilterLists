import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { GridModule } from '@angular/flex-layout';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { MatChipsModule } from '@angular/material/chips';
import { MatIconModule } from '@angular/material/icon';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatTooltipModule } from '@angular/material/tooltip';
import { RouterModule, Routes } from '@angular/router';

import { DetailsComponent } from './details.component';
import { HeaderComponent } from './header/header.component';
import { LanguagesComponent } from './languages/languages.component';
import { LicenseComponent } from './license/license.component';
import { LinksComponent } from './links/links.component';
import { LinksInfoComponent } from './links-info/links-info.component';
import { MaintainerComponent } from './maintainer/maintainer.component';
import { SyntaxesComponent } from './syntaxes/syntaxes.component';
import { TagsComponent } from './tags/tags.component';

const routes: Routes = [
  {
    path: 'lists/:listId',
    component: DetailsComponent,
  },
];

@NgModule({
  declarations: [
    DetailsComponent,
    HeaderComponent,
    LanguagesComponent,
    LicenseComponent,
    LinksComponent,
    LinksInfoComponent,
    MaintainerComponent,
    SyntaxesComponent,
    TagsComponent,
  ],
  imports: [
    CommonModule,
    GridModule,
    MatButtonModule,
    MatCardModule,
    MatChipsModule,
    MatIconModule,
    MatSidenavModule,
    MatTooltipModule,
    RouterModule.forChild(routes),
  ],
})
export class DetailsModule {}
