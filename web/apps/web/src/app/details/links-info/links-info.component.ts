import { ChangeDetectionStrategy, Component, Input } from '@angular/core';

import { FilterListDetails } from '../../services/filter-list-details';

@Component({
  selector: 'filterlists-links-info',
  templateUrl: './links-info.component.html',
  styleUrls: ['./links-info.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class LinksInfoComponent {
  @Input() listDetails: FilterListDetails | undefined;
}
