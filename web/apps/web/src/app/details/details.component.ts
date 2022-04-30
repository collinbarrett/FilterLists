import { ChangeDetectionStrategy, Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { map, switchMap } from 'rxjs';

import { ApiService } from '../services/api.service';

@Component({
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class DetailsComponent {
  readonly listDetails$ = this.route.params.pipe(
    map((params) => params['listId']),
    switchMap((listId) => this.apiService.getListDetails(listId))
  );

  constructor(
    private readonly route: ActivatedRoute,
    private readonly apiService: ApiService
  ) {}
}
