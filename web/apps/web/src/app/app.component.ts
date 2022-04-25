import { Component, OnInit } from '@angular/core';
import { ApiService } from './api.service';
import { FilterListSummary } from './FilterListSummary';

@Component({
  selector: 'filterlists-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent implements OnInit {
  readonly displayedColumns: string[] = ['name', 'description', 'license'];
  dataSource: FilterListSummary[] = [];

  constructor(private readonly api: ApiService) {}

  ngOnInit() {
    this.api.getLists().subscribe((lists) => (this.dataSource = lists));
  }
}
