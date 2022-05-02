import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { GridModule } from '@angular/flex-layout';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { MatChipsModule } from '@angular/material/chips';
import { MatIconModule } from '@angular/material/icon';
import { MatListModule } from '@angular/material/list';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatTooltipModule } from '@angular/material/tooltip';
import { RouterModule, Routes } from '@angular/router';

import { DependencyListsComponent } from './dependency-lists/dependency-lists.component';
import { DependentListsComponent } from './dependent-lists/dependent-lists.component';
import { DetailsComponent } from './details.component';
import { ForkListsComponent } from './fork-lists/fork-lists.component';
import { HeaderComponent } from './header/header.component';
import { IncludedInListsComponent } from './included-in-lists/included-in-lists.component';
import { IncludesListsComponent } from './includes-lists/includes-lists.component';
import { LanguagesComponent } from './languages/languages.component';
import { LicenseComponent } from './license/license.component';
import { LinksComponent } from './links/links.component';
import { LinksInfoComponent } from './links-info/links-info.component';
import { MaintainerComponent } from './maintainer/maintainer.component';
import { SyntaxesComponent } from './syntaxes/syntaxes.component';
import { TagsComponent } from './tags/tags.component';
import { UpstreamListsComponent } from './upstream-lists/upstream-lists.component';

const routes: Routes = [
  {
    path: 'lists/:listId',
    component: DetailsComponent,
  },
];

@NgModule({
  declarations: [
    DetailsComponent,
    DependencyListsComponent,
    DependentListsComponent,
    ForkListsComponent,
    HeaderComponent,
    IncludedInListsComponent,
    IncludesListsComponent,
    LanguagesComponent,
    LicenseComponent,
    LinksComponent,
    LinksInfoComponent,
    MaintainerComponent,
    SyntaxesComponent,
    TagsComponent,
    UpstreamListsComponent,
  ],
  imports: [
    CommonModule,
    GridModule,
    MatButtonModule,
    MatCardModule,
    MatChipsModule,
    MatIconModule,
    MatListModule,
    MatSidenavModule,
    MatTooltipModule,
    RouterModule.forChild(routes),
  ],
})
export class DetailsModule {}
