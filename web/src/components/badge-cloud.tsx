"use client";

import { Badge } from "@/components/ui/badge";
import {
  Tooltip,
  TooltipContent,
  TooltipProvider,
  TooltipTrigger,
} from "@/components/ui/tooltip";

interface BadgeItem {
  key: number;
  value: string;
  tooltip?: string;
  href?: string;
}

interface BadgeCloudProps {
  items: readonly BadgeItem[];
}

const BadgeElement = ({ item }: { item: BadgeItem }) => {
  const badge = <Badge variant="secondary">{item.value}</Badge>;

  return item.href ? (
    <a
      href={item.href}
      target="_blank"
      rel="noopener noreferrer"
      aria-label={item.tooltip ?? `View ${item.value}'s homepage`}
    >
      {badge}
    </a>
  ) : (
    badge
  );
};

export function BadgeCloud({ items }: BadgeCloudProps) {
  const hasTooltips = items.some((item) => item.tooltip || item.href);

  const badges = items.map((item) =>
    item.tooltip || item.href ? (
      <Tooltip key={item.key}>
        <TooltipTrigger>
          <BadgeElement item={item} />
        </TooltipTrigger>
        <TooltipContent>
          <p>{item.tooltip ?? `View ${item.value}'s homepage`}</p>
        </TooltipContent>
      </Tooltip>
    ) : (
      <BadgeElement key={item.key} item={item} />
    ),
  );

  return (
    <div className="flex flex-wrap gap-1">
      {hasTooltips ? <TooltipProvider>{badges}</TooltipProvider> : badges}
    </div>
  );
}
