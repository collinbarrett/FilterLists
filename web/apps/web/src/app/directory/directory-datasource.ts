import { DataSource } from '@angular/cdk/collections';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { BehaviorSubject, merge, Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { ApiService } from '../services/api.service';
import { FilterListSummary } from '../services/filter-list-summary';

export class DirectoryDataSource extends DataSource<FilterListSummary> {
  paginator: MatPaginator | undefined;
  sort: MatSort | undefined;
  datastream = new BehaviorSubject<FilterListSummary[]>([]);

  constructor(private readonly api: ApiService) {
    super();
  }

  connect(): Observable<FilterListSummary[]> {
    this.api.getListSummaries().subscribe((data) => {
      this.datastream.next(data);
    });
    if (this.paginator && this.sort) {
      return merge(
        this.datastream,
        this.paginator.page,
        this.sort.sortChange
      ).pipe(
        map(() => {
          return this.getPagedData(
            this.getSortedData(this.datastream.getValue())
          );
        })
      );
    } else {
      throw Error(
        'Please set the paginator and sort on the data source before connecting.'
      );
    }
  }

  disconnect() {
    return;
  }

  private getPagedData(data: FilterListSummary[]) {
    if (this.paginator) {
      const startIndex = this.paginator.pageIndex * this.paginator.pageSize;
      return data.splice(startIndex, this.paginator.pageSize);
    } else {
      return data;
    }
  }

  private getSortedData(data: FilterListSummary[]) {
    if (!this.sort || !this.sort.active || this.sort.direction === '') {
      return data;
    }

    return data.sort((a, b) => {
      const isAsc = this.sort?.direction === 'asc';
      switch (this.sort?.active) {
        case 'name':
          return compare(a.name, b.name, isAsc);
        case 'description':
          return compare(+a.description, +b.description, isAsc);
        case 'license':
          return compare(+a.license, +b.license, isAsc);
        default:
          return 0;
      }
    });
  }
}

function compare(a: string | number, b: string | number, isAsc: boolean) {
  return (a < b ? -1 : 1) * (isAsc ? 1 : -1);
}
