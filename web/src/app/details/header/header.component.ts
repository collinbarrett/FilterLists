import { ChangeDetectionStrategy, Component, Input } from '@angular/core';

import { FilterListDetails } from '../../services/filter-list-details';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class HeaderComponent {
  @Input() listDetails: FilterListDetails | undefined;
}
