import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

import { environment } from '../../environments/environment';
import { FilterListDetails } from './filter-list-details';
import { FilterListSummary } from './filter-list-summary';

@Injectable({
  providedIn: 'root',
})
export class ApiService {
  constructor(private readonly http: HttpClient) {}

  getListSummaries() {
    return this.http.get<FilterListSummary[]>(environment.apiUrl + 'lists');
  }

  getListDetails(listId: number) {
    return this.http.get<FilterListDetails>(
      environment.apiUrl + 'lists/' + listId
    );
  }
}
