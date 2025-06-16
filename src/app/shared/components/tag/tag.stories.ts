import { Meta, StoryObj } from '@storybook/angular';
import { TagComponent } from './tag.component';

const meta: Meta<TagComponent> = {
  title: 'Components/Tag',
  component: TagComponent,
  tags: ['autodocs'],
  argTypes: {
    color: {
      control: {
        type: 'select',
      },
      options: ['green', 'blue', 'red', 'yellow', 'gray'],

      description: 'The color of the tag',
      table: {
        type: { summary: 'string' },
        defaultValue: { summary: 'green' },
      },
    },
    label: {
      control: 'text',
      description: 'The text displayed inside the tag',
      table: {
        type: { summary: 'string' },
        defaultValue: { summary: 'Tag' },
      },
    },
  },
};

export default meta;
type Story = StoryObj<TagComponent>;

export const Red: Story = {
  args: {
    color: 'red',
    label: 'Critico',
  },
};

export const Yellow: Story = {
  args: {
    color: 'yellow',
    label: 'Advertencia',
  },
};

export const Green: Story = {
  args: {
    color: 'green',
    label: 'Facilito',
  },
};
