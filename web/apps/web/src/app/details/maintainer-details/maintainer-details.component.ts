import { ChangeDetectionStrategy, Component, Input } from '@angular/core';

import { Maintainer } from '../../services/filter-list-details';

@Component({
  selector: 'filterlists-maintainer-details',
  templateUrl: './maintainer-details.component.html',
  styleUrls: ['./maintainer-details.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class MaintainerDetailsComponent {
  @Input() maintainer: Maintainer | undefined;
}
