"use client";

import { Badge } from "@/components/ui/badge";
import {
  Tooltip,
  TooltipContent,
  TooltipProvider,
  TooltipTrigger,
} from "@/components/ui/tooltip";
import { Language } from "@/services/get-languages";

interface LanguageBadgesProps {
  languages: Language[];
}

export function LanguageBadges({ languages }: LanguageBadgesProps) {
  return (
    <div className="flex flex-wrap gap-1">
      <TooltipProvider>
        {languages.map((language) => (
          <Tooltip key={language.id}>
            <TooltipTrigger>
              <Badge variant="secondary">{language.iso6391}</Badge>
            </TooltipTrigger>
            <TooltipContent>
              <p>{language.name}</p>
            </TooltipContent>
          </Tooltip>
        ))}
      </TooltipProvider>
    </div>
  );
}
