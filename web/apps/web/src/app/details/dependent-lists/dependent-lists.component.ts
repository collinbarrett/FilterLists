import { ChangeDetectionStrategy, Component, Input } from '@angular/core';

import { RelatedFilterList } from '../../services/filter-list-details';

@Component({
  selector: 'filterlists-dependent-lists',
  templateUrl: './dependent-lists.component.html',
  styleUrls: ['./dependent-lists.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class DependentListsComponent {
  @Input() dependentLists: RelatedFilterList[] | undefined;
}
