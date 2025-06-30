"use client";

import { useRouter } from "next/navigation";
import {
  Sheet,
  SheetContent,
  SheetHeader,
  SheetTitle,
} from "@/components/ui/sheet";
import { FilterListDetails } from "@/services/get-filterlist-details";

export function SheetContentRenderer({
  list,
}: {
  list: FilterListDetails | null;
}) {
  const router = useRouter();

  const handleOpenChange = (isOpen: boolean) => {
    if (!isOpen) {
      router.back();
    }
  };

  return (
    <Sheet open={true} onOpenChange={handleOpenChange}>
      <SheetContent>
        <SheetHeader>
          <SheetTitle>{list?.name}</SheetTitle>
        </SheetHeader>
        {list ? (
          <div>
            <p>{list.description}</p>
            {/* Render more details as needed */}
          </div>
        ) : (
          <p>Loading...</p>
        )}
      </SheetContent>
    </Sheet>
  );
}
