import { Syntax } from "../../interfaces/Syntax";
import { SyntaxTag } from "../SyntaxTag";

interface Props {
  syntaxes: Syntax[];
  showLabel?: boolean;
}

export const SyntaxCloud = (props: Props) =>
  props.syntaxes && props.syntaxes.length ? (
    <div>
      {props.showLabel && (
        <h3>{`Syntax${props.syntaxes.length > 1 ? "es" : ""}:`}</h3>
      )}
      {props.syntaxes.map((s: Syntax, i: number) => (
        <SyntaxTag key={i} name={s.name} definitionUrl={s.url} />
      ))}
    </div>
  ) : null;
