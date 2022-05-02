import { ChangeDetectionStrategy, Component, Input } from '@angular/core';

import { RelatedFilterList } from '../../services/filter-list-details';

@Component({
  selector: 'filterlists-dependency-lists',
  templateUrl: './dependency-lists.component.html',
  styleUrls: ['./dependency-lists.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class DependencyListsComponent {
  @Input() dependencyLists: RelatedFilterList[] | undefined;
}
