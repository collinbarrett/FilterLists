import { Component, Input } from '@angular/core';

import { FilterListDetails } from '../../services/filter-list-details';

@Component({
  selector: 'filterlists-links',
  templateUrl: './links.component.html',
  styleUrls: ['./links.component.scss'],
})
export class LinksComponent {
  @Input() filterListDetails: FilterListDetails | undefined;
}
