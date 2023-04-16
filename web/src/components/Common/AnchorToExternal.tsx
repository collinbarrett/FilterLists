interface Props extends React.AnchorHTMLAttributes<HTMLAnchorElement> {
  children: React.ReactNode;
}

export const AnchorToExternal = ({ children, ...rest }: Props) => (
  <a {...rest} target="_blank" rel="noopener noreferrer">
    {children}
  </a>
);
