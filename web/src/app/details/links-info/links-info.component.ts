import { ChangeDetectionStrategy, Component, Input } from '@angular/core';

import { FilterListDetails } from '../../services/filter-list-details';

@Component({
  selector: 'app-links-info',
  templateUrl: './links-info.component.html',
  styleUrls: ['./links-info.component.css'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class LinksInfoComponent {
  @Input() listDetails: FilterListDetails | undefined;
}
