import { BreakpointObserver, Breakpoints } from '@angular/cdk/layout';
import { Component } from '@angular/core';
import { map, Observable, shareReplay } from 'rxjs';
import { FilterListSummary } from './services/filter-list-summary';

@Component({
  selector: 'filterlists-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent {
  readonly displayedColumns: string[] = ['name', 'description', 'license'];
  readonly isHandset$: Observable<boolean> = this.breakpointObserver
    .observe(Breakpoints.Handset)
    .pipe(
      map((result) => result.matches),
      shareReplay()
    );
  dataSource: FilterListSummary[] = [];

  constructor(private readonly breakpointObserver: BreakpointObserver) {}
}
