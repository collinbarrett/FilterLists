import { ChangeDetectionStrategy, Component, Input } from '@angular/core';

import { RelatedFilterList } from '../../services/filter-list-details';

@Component({
  selector: 'filterlists-fork-lists',
  templateUrl: './fork-lists.component.html',
  styleUrls: ['./fork-lists.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class ForkListsComponent {
  @Input() forkLists: RelatedFilterList[] | undefined;
}
