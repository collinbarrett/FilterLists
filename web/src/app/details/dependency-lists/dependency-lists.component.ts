import { ChangeDetectionStrategy, Component, Input } from '@angular/core';

import { RelatedFilterList } from '../../services/filter-list-details';

@Component({
  selector: 'app-dependency-lists',
  templateUrl: './dependency-lists.component.html',
  styleUrls: ['./dependency-lists.component.css'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class DependencyListsComponent {
  @Input() dependencyLists: RelatedFilterList[] | undefined;
}
