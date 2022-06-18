import { ChangeDetectionStrategy, Component, Input } from '@angular/core';

import { Maintainer } from '../../services/filter-list-details';

@Component({
  selector: 'app-maintainer',
  templateUrl: './maintainer.component.html',
  styleUrls: ['./maintainer.component.css'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class MaintainerComponent {
  @Input() maintainer: Maintainer | undefined;
}
