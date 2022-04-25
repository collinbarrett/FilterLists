import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../environments/environment';
import { FilterListSummary } from './FilterListSummary';

@Injectable({
  providedIn: 'root',
})
export class ApiService {
  constructor(private readonly http: HttpClient) {}

  getLists() {
    return this.http.get<FilterListSummary[]>(environment.apiUrl + 'lists');
  }
}
