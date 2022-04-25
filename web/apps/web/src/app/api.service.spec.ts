import { HttpClientModule } from '@angular/common/http';
import { TestBed, waitForAsync } from '@angular/core/testing';

import { ApiService } from './api.service';

describe('ApiService', () => {
  let service: ApiService;

  beforeEach(waitForAsync(() => {
    TestBed.configureTestingModule({
      providers: [HttpClientModule],
    }).compileComponents();
  }));

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
