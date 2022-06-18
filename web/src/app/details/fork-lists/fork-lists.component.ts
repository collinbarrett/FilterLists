import { ChangeDetectionStrategy, Component, Input } from '@angular/core';

import { RelatedFilterList } from '../../services/filter-list-details';

@Component({
  selector: 'app-fork-lists',
  templateUrl: './fork-lists.component.html',
  styleUrls: ['./fork-lists.component.css'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class ForkListsComponent {
  @Input() forkLists: RelatedFilterList[] | undefined;
}
