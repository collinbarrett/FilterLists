import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { FilterListSummary } from './filter-list-summary';
import { environment } from '../../environments/environment';

@Injectable({
  providedIn: 'root',
})
export class ApiService {
  constructor(private readonly http: HttpClient) {}

  getLists() {
    return this.http.get<FilterListSummary[]>(environment.apiUrl + 'lists');
  }
}
