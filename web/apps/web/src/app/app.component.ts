import { Component, OnInit } from '@angular/core';
import { ApiService, FilterListSummary } from './api.service';

@Component({
  selector: 'filterlists-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
})
export class AppComponent implements OnInit {
  displayedColumns: string[] = ['name', 'description', 'license'];
  dataSource: FilterListSummary[] = [];

  constructor(private readonly api: ApiService) {}

  ngOnInit() {
    this.api.getLists().subscribe((s) => (this.dataSource = s));
  }
}
