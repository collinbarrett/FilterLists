import { ChangeDetectionStrategy, Component, Input } from '@angular/core';

import { RelatedFilterList } from '../../services/filter-list-details';

@Component({
  selector: 'app-included-in-lists',
  templateUrl: './included-in-lists.component.html',
  styleUrls: ['./included-in-lists.component.css'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class IncludedInListsComponent {
  @Input() includedInLists: RelatedFilterList[] | undefined;
}
