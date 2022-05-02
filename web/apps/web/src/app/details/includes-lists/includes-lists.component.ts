import { ChangeDetectionStrategy, Component, Input } from '@angular/core';

import { RelatedFilterList } from '../../services/filter-list-details';

@Component({
  selector: 'filterlists-includes-lists',
  templateUrl: './includes-lists.component.html',
  styleUrls: ['./includes-lists.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class IncludesListsComponent {
  @Input() includesLists: RelatedFilterList[] | undefined;
}
