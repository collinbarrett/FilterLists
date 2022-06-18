import { ChangeDetectionStrategy, Component, Input } from '@angular/core';

import { RelatedFilterList } from '../../services/filter-list-details';

@Component({
  selector: 'app-upstream-lists',
  templateUrl: './upstream-lists.component.html',
  styleUrls: ['./upstream-lists.component.css'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class UpstreamListsComponent {
  @Input() upstreamLists: RelatedFilterList[] | undefined;
}
