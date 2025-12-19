import { test, expect } from '@playwright/test';

test('should display correct name in h1', async ({ page }) => {
  await page.goto('/');
  await expect(page.locator('h1')).toHaveText('Quinntyne Brown');
});
