import { ChangeDetectionStrategy, Component, Input } from '@angular/core';

import { RelatedFilterList } from '../../services/filter-list-details';

@Component({
  selector: 'filterlists-upstream-lists',
  templateUrl: './upstream-lists.component.html',
  styleUrls: ['./upstream-lists.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class UpstreamListsComponent {
  @Input() upstreamLists: RelatedFilterList[] | undefined;
}
