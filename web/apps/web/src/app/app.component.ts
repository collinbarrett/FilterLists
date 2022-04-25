import { BreakpointObserver, Breakpoints } from '@angular/cdk/layout';
import { Component, OnInit } from '@angular/core';
import { map, Observable, shareReplay } from 'rxjs';
import { ApiService } from './api.service';
import { FilterListSummary } from './filter-list-summary';

@Component({
  selector: 'filterlists-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent implements OnInit {
  readonly displayedColumns: string[] = ['name', 'description', 'license'];
  readonly isHandset$: Observable<boolean> = this.breakpointObserver
    .observe(Breakpoints.Handset)
    .pipe(
      map((result) => result.matches),
      shareReplay()
    );
  dataSource: FilterListSummary[] = [];

  constructor(
    private readonly api: ApiService,
    private readonly breakpointObserver: BreakpointObserver
  ) {}

  ngOnInit() {
    this.api.getLists().subscribe((lists) => (this.dataSource = lists));
  }
}
