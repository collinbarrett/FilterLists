import { ChangeDetectionStrategy, Component, Input } from '@angular/core';

import { Syntax } from '../../services/filter-list-details';

@Component({
  selector: 'filterlists-syntaxes',
  templateUrl: './syntaxes.component.html',
  styleUrls: ['./syntaxes.component.scss'],
  changeDetection: ChangeDetectionStrategy.OnPush,
})
export class SyntaxesComponent {
  @Input() syntaxes: Syntax[] | undefined;
}
