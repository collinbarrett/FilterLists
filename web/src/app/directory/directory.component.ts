import { AfterViewInit, Component, ViewChild } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTable } from '@angular/material/table';

import { ApiService } from '../services/api.service';
import { FilterListSummary } from '../services/filter-list-summary';
import { DirectoryDataSource } from './directory-datasource';

@Component({
  templateUrl: './directory.component.html',
  styleUrls: ['./directory.component.css'],
})
export class DirectoryComponent implements AfterViewInit {
  @ViewChild(MatPaginator) readonly paginator!: MatPaginator;
  @ViewChild(MatSort) readonly sort!: MatSort;
  @ViewChild(MatTable) readonly table!: MatTable<FilterListSummary>;
  readonly dataSource: DirectoryDataSource;

  readonly displayedColumns = [
    'details',
    'name',
    'description',
    'software',
    'syntaxes',
    'languages',
    'tags',
    'maintainers',
    'license',
  ];

  constructor(api: ApiService) {
    this.dataSource = new DirectoryDataSource(api);
  }

  ngAfterViewInit() {
    this.dataSource.sort = this.sort;
    this.dataSource.paginator = this.paginator;
    this.table.dataSource = this.dataSource;
  }
}
