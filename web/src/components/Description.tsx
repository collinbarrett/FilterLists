interface Props {
  description?: string;
}

export const Description = (props: Props) =>
  props.description ? <p>{props.description}</p> : null;
