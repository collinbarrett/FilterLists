import { ChangeDetectionStrategy, Component, Input } from '@angular/core';

import { Tag } from '../../services/filter-list-details';

@Component({
  selector: 'filterlists-tags',
  templateUrl: './tags.component.html',
  styleUrls: ['./tags.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class TagsComponent {
  @Input() tags: Tag[] | undefined;
}
