import { ChangeDetectionStrategy, Component, Input } from '@angular/core';

import { RelatedFilterList } from '../../services/filter-list-details';

@Component({
  selector: 'app-dependent-lists',
  templateUrl: './dependent-lists.component.html',
  styleUrls: ['./dependent-lists.component.css'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class DependentListsComponent {
  @Input() dependentLists: RelatedFilterList[] | undefined;
}
