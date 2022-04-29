import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { map } from 'rxjs';

@Component({
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.scss'],
})
export class DetailsComponent {
  readonly listId$ = this.route.params.pipe(map((params) => params['listId']));

  constructor(private readonly route: ActivatedRoute) {}
}
