import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class ApiService {
  constructor(private http: HttpClient) {}

  getLists() {
    return this.http.get<FilterListSummary[]>(
      'http://localhost:7071/api/lists'
    );
  }
}

export interface FilterListSummary {
  name: string;
  description: string;
  software: string[];
  syntaxes: string[];
  languages: string[];
  tags: string[];
  maintainers: string[];
  license: string;
}
