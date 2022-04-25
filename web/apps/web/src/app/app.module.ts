import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import { MatToolbarModule } from '@angular/material/toolbar';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import { LayoutModule } from '@angular/cdk/layout';
import { MatButtonModule } from '@angular/material/button';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatListModule } from '@angular/material/list';
import { Routes, RouterModule } from '@angular/router';

const routes: Routes = [
  {
    path: '',
    loadChildren: () =>
      import('./directory/directory.module').then((d) => d.DirectoryModule),
  },
];

@NgModule({
  declarations: [AppComponent],
  imports: [
    BrowserAnimationsModule,
    HttpClientModule,
    LayoutModule,
    MatButtonModule,
    MatListModule,
    MatSidenavModule,
    MatToolbarModule,
    RouterModule.forRoot(routes),
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
